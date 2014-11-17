﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEDExplorer
{
    class Iec61850Model
    {
        /// <summary>
        /// Server data
        /// </summary>
        public NodeIed ied = new NodeIed("ied");
        /// <summary>
        /// Server named variable lists
        /// </summary>
        public NodeIed lists = new NodeIed("lists");
        /// <summary>
        /// Server RP blocks (reports)
        /// </summary>
        public NodeIed reports = new NodeIed("reports");
        /// <summary>
        /// Server files
        /// </summary>
        public NodeIed files = new NodeIed("files");

        public Iec61850Model(Iec61850State iecs)
        {
            (ied as NodeIed).iecs = iecs;
            (lists as NodeIed).iecs = iecs;
            (files as NodeIed).iecs = iecs;
            (reports as NodeIed).iecs = iecs;
        }
    }
}