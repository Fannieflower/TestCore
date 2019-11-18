using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class ProblemOrderHelper : TBeanSerializer<ProblemOrder>
	{
		
		public static ProblemOrderHelper OBJ = new ProblemOrderHelper();
		
		public static ProblemOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProblemOrder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("wd_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWd_no(value);
					}
					
					
					
					
					
					if ("category_3_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory_3_name(value);
					}
					
					
					
					
					
					if ("vis_status_str".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVis_status_str(value);
					}
					
					
					
					
					
					if ("is_delay_str".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIs_delay_str(value);
					}
					
					
					
					
					
					if ("end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEnd_time(value);
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
		
		
		public void Write(ProblemOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWd_no() != null) {
				
				oprot.WriteFieldBegin("wd_no");
				oprot.WriteString(structs.GetWd_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory_3_name() != null) {
				
				oprot.WriteFieldBegin("category_3_name");
				oprot.WriteString(structs.GetCategory_3_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVis_status_str() != null) {
				
				oprot.WriteFieldBegin("vis_status_str");
				oprot.WriteString(structs.GetVis_status_str());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_delay_str() != null) {
				
				oprot.WriteFieldBegin("is_delay_str");
				oprot.WriteString(structs.GetIs_delay_str());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnd_time() != null) {
				
				oprot.WriteFieldBegin("end_time");
				oprot.WriteString(structs.GetEnd_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProblemOrder bean){
			
			
		}
		
	}
	
}