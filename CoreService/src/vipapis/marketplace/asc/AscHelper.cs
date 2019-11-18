using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class AscHelper : TBeanSerializer<Asc>
	{
		
		public static AscHelper OBJ = new AscHelper();
		
		public static AscHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Asc structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("asc_brief".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.marketplace.asc.AscBrief value;
						
						value = new vipapis.marketplace.asc.AscBrief();
						vipapis.marketplace.asc.AscBriefHelper.getInstance().Read(value, iprot);
						
						structs.SetAsc_brief(value);
					}
					
					
					
					
					
					if ("problem_order_sns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProblem_order_sns(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(Asc structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAsc_brief() != null) {
				
				oprot.WriteFieldBegin("asc_brief");
				
				vipapis.marketplace.asc.AscBriefHelper.getInstance().Write(structs.GetAsc_brief(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProblem_order_sns() != null) {
				
				oprot.WriteFieldBegin("problem_order_sns");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetProblem_order_sns()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Asc bean){
			
			
		}
		
	}
	
}