using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V28.Group;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Message

{
///<summary>
/// Represents a QBP_Z73 message structure (see chapter 4.6.2). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: SFT (Software Segment) optional repeating</li>
///<li>2: UAC (User Authentication Credential Segment) optional </li>
///<li>3: QPD (Query Parameter Definition) </li>
///<li>4: RCP (Response Control Parameter) </li>
///</ol>
///</summary>
[Serializable]
public class QBP_Z73 : AbstractMessage  {

	///<summary> 
	/// Creates a new QBP_Z73 Group with custom IModelClassFactory.
	///</summary>
	public QBP_Z73(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new QBP_Z73 Group with DefaultModelClassFactory. 
	///</summary> 
	public QBP_Z73() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for QBP_Z73.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(UAC), false, false);
	      this.add(typeof(QPD), true, false);
	      this.add(typeof(RCP), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating QBP_Z73 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SFT (Software Segment) - creates it if necessary
	///</summary>
	public SFT GetSFT() {
	   SFT ret = null;
	   try {
	      ret = (SFT)this.GetStructure("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SFT
	/// * (Software Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SFT GetSFT(int rep) { 
	   return (SFT)this.GetStructure("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SFT results 
	 */ 
	public IEnumerable<SFT> SFTs 
	{ 
		get
		{
			for (int rep = 0; rep < SFTRepetitionsUsed; rep++)
			{
				yield return (SFT)this.GetStructure("SFT", rep);
			}
		}
	}

	///<summary>
	///Adds a new SFT
	///</summary>
	public SFT AddSFT()
	{
		return this.AddStructure("SFT") as SFT;
	}

	///<summary>
	///Removes the given SFT
	///</summary>
	public void RemoveSFT(SFT toRemove)
	{
		this.RemoveStructure("SFT", toRemove);
	}

	///<summary>
	///Removes the SFT at the given index
	///</summary>
	public void RemoveSFTAt(int index)
	{
		this.RemoveRepetition("SFT", index);
	}

	///<summary>
	/// Returns UAC (User Authentication Credential Segment) - creates it if necessary
	///</summary>
	public UAC UAC { 
get{
	   UAC ret = null;
	   try {
	      ret = (UAC)this.GetStructure("UAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QPD (Query Parameter Definition) - creates it if necessary
	///</summary>
	public QPD QPD { 
get{
	   QPD ret = null;
	   try {
	      ret = (QPD)this.GetStructure("QPD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RCP (Response Control Parameter) - creates it if necessary
	///</summary>
	public RCP RCP { 
get{
	   RCP ret = null;
	   try {
	      ret = (RCP)this.GetStructure("RCP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
