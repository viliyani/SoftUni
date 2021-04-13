﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class DepartmentCellInputModel
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        public List<CellInputModel> Cells { get; set; }

    }
}

//{
//    "Name": "",
//    "Cells": [
//      {
//        "CellNumber": 101,
//        "HasWindow": true
//      },
//      {
//        "CellNumber": 102,
//        "HasWindow": false
//      }
//    ]
//  },