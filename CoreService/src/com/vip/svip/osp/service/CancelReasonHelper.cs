using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class CancelReasonHelper : TBeanSerializer<CancelReason>
	{
		
		public static CancelReasonHelper OBJ = new CancelReasonHelper();
		
		public static CancelReasonHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CancelReason structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("reasonId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReasonId(value);
					}
					
					
					
					
					
					if ("quota".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetQuota(value);
					}
					
					
					
					
					
					if ("detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDetail(value);
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
		
		
		public void Write(CancelReason structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReasonId() != null) {
				
				oprot.WriteFieldBegin("reasonId");
				oprot.WriteI32((int)structs.GetReasonId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuota() != null) {
				
				oprot.WriteFieldBegin("quota");
				oprot.WriteString(structs.GetQuota());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetail() != null) {
				
				oprot.WriteFieldBegin("detail");
				oprot.WriteString(structs.GetDetail());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CancelReason bean){
			
			
		}
		
	}
	
}