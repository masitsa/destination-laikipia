using DestinationLaikipia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DestinationLaikipia.ViewModels
{
   public class ItemListViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }

        public ItemListViewModel()
        {
            this.Posts = new ObservableCollection<Post>();
            //testing
            this.Posts.Add(new Post
            {
                Title = "tests"
            });
            this.Posts.Add(new Post
            {
                Title = "test2"
            });
        }
    }
}
