﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TeamMentor.CoreLib;

namespace TeamMentor.UnitTests
{
	public class TM_XmlDatabase_InMemory
	{
		public TM_Xml_Database tmXmlDatabase;
		
		public TM_XmlDatabase_InMemory()
		{
			
		}

		[TestFixtureSetUp]		
		public void TestFixtureSetUp()
		{
			tmXmlDatabase = new TM_Xml_Database(false);	

			//all these values should be null since we are running TM all in memory
			Assert.IsNull(tmXmlDatabase.Path_XmlDatabase		, "Path_XmlDatabase");
			Assert.IsNull(tmXmlDatabase.Path_XmlLibraries		, "Path_XmlLibraries");
			Assert.IsEmpty(tmXmlDatabase.Cached_GuidanceItems	, "Cached_GuidanceItems");
			Assert.IsEmpty(tmXmlDatabase.ActiveSessions			, "ActiveSessions");
			Assert.IsEmpty(tmXmlDatabase.TMUsers				, "TMUsers");
		}
	}
}
