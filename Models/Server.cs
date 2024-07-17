using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
	public class Server 
	{
		public Server() { 
			Random random = new Random();
			int randomNumber = random.Next(0,2);

			this.IsOnline = randomNumber == 0 ? false: true ;	
		}
        public int ServerId { get; set; }
		public bool IsOnline { get; set; }
		[Required(ErrorMessage ="THIS IS A CUSMTOM ERROR")]
		public string? Name { get; set;}
		[Required]
		 
		public string? City { get; set;}
	
    }
}
