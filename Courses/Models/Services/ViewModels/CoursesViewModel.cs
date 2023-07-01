using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses.Models.ValueObjects;

namespace Courses.Models.ViewModels
{
    public class CoursesViewModel
    {
        public Guid Id {get;set;}
        public string? Title {get;set;}
        public string? Description {get;set;}
        public string? Author {get;set;}
        public string? ImagePath{get;set;}
        public string? Email {get;set;}
        public double Rating {get;set;}
	    public Money? CurrentPrice {get;set;}
	    public Money? FullPrice {get;set;}
    }
}