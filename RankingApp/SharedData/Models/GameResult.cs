﻿using System;
using System.Collections.Generic;
using System.Text;


namespace SharedData.Models
{
    public class GameResult
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public DateTime PlayedOn { get; set; }
    }
}
