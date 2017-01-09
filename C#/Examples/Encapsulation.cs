using System;

namespace Encapsulation 
{

    class Demo
    {
        private int _mark;

        public int Mark
        {
            get { return _mark; }
            set { if (_mark > 0) _mark = value; else _mark = 0; }
        }
    }

}
/* Output
 * 
*/
