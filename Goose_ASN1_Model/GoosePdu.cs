
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace GOOSE_ASN1_Model {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "GoosePdu", IsSet = false  )]
    public class GoosePdu : IASN1PreparedElement {
                    
	private string gocbRef_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.VisibleString , IsUCS = false )]
        [ASN1Element ( Name = "gocbRef", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public string GocbRef
        {
            get { return gocbRef_; }
            set { gocbRef_ = value;  }
        }
        
                
          
	private long timeAllowedtoLive_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "timeAllowedtoLive", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public long TimeAllowedtoLive
        {
            get { return timeAllowedtoLive_; }
            set { timeAllowedtoLive_ = value;  }
        }
        
                
          
	private string datSet_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.VisibleString , IsUCS = false )]
        [ASN1Element ( Name = "datSet", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public string DatSet
        {
            get { return datSet_; }
            set { datSet_ = value;  }
        }
        
                
          
	private string goID_ ;
	
        private bool  goID_present = false ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.VisibleString , IsUCS = false )]
        [ASN1Element ( Name = "goID", IsOptional =  true , HasTag =  true, Tag = 3 , HasDefaultValue =  false )  ]
    
        public string GoID
        {
            get { return goID_; }
            set { goID_ = value; goID_present = true;  }
        }
        
                
          
	private UtcTime t_ ;
	
        [ASN1Element ( Name = "t", IsOptional =  false , HasTag =  true, Tag = 4 , HasDefaultValue =  false )  ]
    
        public UtcTime T
        {
            get { return t_; }
            set { t_ = value;  }
        }
        
                
          
	private long stNum_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "stNum", IsOptional =  false , HasTag =  true, Tag = 5 , HasDefaultValue =  false )  ]
    
        public long StNum
        {
            get { return stNum_; }
            set { stNum_ = value;  }
        }
        
                
          
	private long sqNum_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "sqNum", IsOptional =  false , HasTag =  true, Tag = 6 , HasDefaultValue =  false )  ]
    
        public long SqNum
        {
            get { return sqNum_; }
            set { sqNum_ = value;  }
        }
        
                
          
	private bool simulation_ ;
	[ASN1Boolean( Name = "" )]
    
        [ASN1Element ( Name = "simulation", IsOptional =  false , HasTag =  true, Tag = 7 , HasDefaultValue =  true )  ]
    
        public bool Simulation
        {
            get { return simulation_; }
            set { simulation_ = value;  }
        }
        
                
          
	private long confRev_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "confRev", IsOptional =  false , HasTag =  true, Tag = 8 , HasDefaultValue =  false )  ]
    
        public long ConfRev
        {
            get { return confRev_; }
            set { confRev_ = value;  }
        }
        
                
          
	private bool ndsCom_ ;
	[ASN1Boolean( Name = "" )]
    
        [ASN1Element ( Name = "ndsCom", IsOptional =  false , HasTag =  true, Tag = 9 , HasDefaultValue =  true )  ]
    
        public bool NdsCom
        {
            get { return ndsCom_; }
            set { ndsCom_ = value;  }
        }
        
                
          
	private long numDatSetEntries_ ;
	[ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "numDatSetEntries", IsOptional =  false , HasTag =  true, Tag = 10 , HasDefaultValue =  false )  ]
    
        public long NumDatSetEntries
        {
            get { return numDatSetEntries_; }
            set { numDatSetEntries_ = value;  }
        }
        
                
          
	private System.Collections.Generic.ICollection<Data> allData_ ;
	
[ASN1SequenceOf( Name = "allData", IsSetOf = false  )]

    
        [ASN1Element ( Name = "allData", IsOptional =  false , HasTag =  true, Tag = 11 , HasDefaultValue =  false )  ]
    
        public System.Collections.Generic.ICollection<Data> AllData
        {
            get { return allData_; }
            set { allData_ = value;  }
        }
        
                
  
        public bool isGoIDPresent () {
            return this.goID_present == true;
        }
        

            public void initWithDefaults() {
            	bool param_Simulation =         
            false;
        Simulation = param_Simulation;
    bool param_NdsCom =         
            false;
        NdsCom = param_NdsCom;
    
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(GoosePdu));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}