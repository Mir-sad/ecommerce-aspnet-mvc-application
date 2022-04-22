using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
       [Required(ErrorMessage ="Name is required")]
       [Display(Name="Movie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in $")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Poster URL is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Start date is required")]
        [Display(Name = "Movie start date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "Movie end date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Movie category is required")]
        [Display(Name = "Select Category")]
        public MovieCategory MovieCategory { get; set; }
        [Required(ErrorMessage = "Movie actor(s) is required")]
        [Display(Name = "Select Actor(s)")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Movie  cinema is required")]
        [Display(Name = "Select a Cinema")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Movie producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }
        

    }
}
