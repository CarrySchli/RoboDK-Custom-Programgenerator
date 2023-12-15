﻿using RoboDk.API.Model;
using RoboDk.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Models
{
    internal class Robots
    {

        private IItem _robot;

        public string Name
        {
            get
            {
                return _robot.Name();
            }
        }

        public Mat pose { get { return _robot.Pose(); } }

        public IItem Robot
        {
            get { return _robot; }
            private set { _robot = value; }
        }


        /// <summary>
        /// Object which represents a Frame.
        /// </summary>
        /// <param name="robot"></param>
        /// <exception cref="ArgumentException"></exception>
        public Robots(IItem robot)
        {
            if (robot.GetItemType() == ItemType.Robot)
            {
                _robot = robot;
            }
        }

        public override string ToString()
        {
            return $"{Name} ; {pose}";
        }
    }
}
