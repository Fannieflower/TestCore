using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	public class TmsOrderUpdateResponseHelper : TBeanSerializer<TmsOrderUpdateResponse>
	{
		
		public static TmsOrderUpdateResponseHelper OBJ = new TmsOrderUpdateResponseHelper();
		
		public static TmsOrderUpdateResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderUpdateResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("respCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRespCode(value);
					}
					
					
					
					
					
					if ("respMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRespMsg(value);
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
		
		
		public void Write(TmsOrderUpdateResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRespCode() != null) {
				
				oprot.WriteFieldBegin("respCode");
				oprot.WriteString(structs.GetRespCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRespMsg() != null) {
				
				oprot.WriteFieldBegin("respMsg");
				oprot.WriteString(structs.GetRespMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderUpdateResponse bean){
			
			
		}
		
	}
	
}