using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DataSource : Subject
    {
		private int value;

		public int Value
		{
			get { return value; }
			set 
			{ 
				this.value = value;
				NotifyObservers();
			}
		}

	}
}
