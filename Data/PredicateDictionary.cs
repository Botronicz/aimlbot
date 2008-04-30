﻿/****************************************************************************
    AimlBot - a library for building all manner of AIML based chat bots for 
    the .NET platform.
    
    Copyright (C) 2008  Nicholas H.Tollervey (http://ntoll.org)

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published 
    by the Free Software Foundation, either version 3 of the License, or (at 
    your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

    To contact the author directly use the contact information found here: 
    http://ntoll.org/about
 
    A full copy of the GNU Affero General Public License can be found in the 
    License.txt file in the Docs folder in the root of this project.
  
    For a commercial license please contact the author.
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace AimlBot.Data
{
    public class PredicateDictionary
    {
        protected Dictionary<string, string> Predicates = new Dictionary<string, string>();

        string ID = string.Empty;

        public string this[string predicate]
        {
            get
            {
                return this.Predicates[predicate];
            }

            set
            {
                this.Predicates[predicate] = value;
            }
        }

        public void ToXml(StringBuilder stringBuilder)
        {
        }

        public void ToXml(XmlDocument xmlDocument)
        {
        }
    }
}
