//not a model, viewModel are plain c sharp classes with specific purpose
//viewbag is fine for simple examples but a better approach is to use an entity model or a custom 'viewmodel'
using System;

namespace SMS.Web.Models
{
  public class AboutViewModel
  {
    public string Title { get; set; } 
    public string Message { get; set; } 
    public DateTime Formed { get; set; } = DateTime.Now;
    public string Company { get; set; }

    //read only properties
    public string FormedStr => Formed.ToLongDateString();
    public int Days => (DateTime.Now - Formed).Days;
    
  }
} 
