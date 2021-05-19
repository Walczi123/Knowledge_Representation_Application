﻿using System;

namespace KR_Lib.DataStructures
{
    public class ActionWithTimes 
    {
        public Guid Id
        {
            get;
        }
        public string Name
        {
            get;
            set;
        }
        public int StartTime
        {
            get;
            set;
        }
        public int DurationTime
        {
            get;
            set;
        }
        private ActionWithTimes() { }
        public ActionWithTimes(string name, int durationTime, int startTime)
        {
            this.Name = name;
            this.StartTime = startTime;
            this.DurationTime = durationTime;
            this.Id = Guid.NewGuid();
        }

        protected ActionWithTimes(Action action, int durationTime, int startTime)
        {
            this.Name = action.Name;
            this.StartTime = startTime;
            this.DurationTime = durationTime;
            this.Id = action.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is ActionWithTimes)
            {
                var action = obj as ActionWithTimes;
                if (action.Id.Equals(this.Id) && action.DurationTime.Equals(this.DurationTime))
                    return true;
            }
            return false;
        }

        public int GetEndTime()
        {
            int time = -1;
            int? endTime = StartTime + DurationTime;

            if (endTime.HasValue)
            {
                time = endTime.Value;
            }

            return time;
        }

        public override string ToString()
        {
            //string description = "Action (" + Id + ", " + Duration + ") with start time: " + StartAt;
            //return description;
            return "(" + this.Name + ", " + this.DurationTime + ")";
        }
    }
}
