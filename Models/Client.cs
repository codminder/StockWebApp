using System.ComponentModel.DataAnnotations.Schema

namespace WebApp.Models

public class Client 
{
  public int id {get; set;}   
  public string required firstName {get; set;}
  public string required lastName {get; set;}
  public string required street {get; set;}
  public string required postalCode {get; set;}
  public int required appartmentNumber {get; set;}
}
