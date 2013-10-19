using System;
using System.Collections.Generic;
using System.Text;

namespace BadApple
{
	class InvalidSSPException : Exception
	{
		public override string Message
		{
			get
			{
				return "Not a valid SSP File";
			}
		}
	}
}
