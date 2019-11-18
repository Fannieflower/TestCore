using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class GetTrusteeshipInfoRequestModelHelper : TBeanSerializer<GetTrusteeshipInfoRequestModel>
	{
		
		public static GetTrusteeshipInfoRequestModelHelper OBJ = new GetTrusteeshipInfoRequestModelHelper();
		
		public static GetTrusteeshipInfoRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetTrusteeshipInfoRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("storeSource".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetStoreSource(value);
					}
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("taxRegisterNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRegisterNo(value);
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
		
		
		public void Write(GetTrusteeshipInfoRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStoreSource() != null) {
				
				oprot.WriteFieldBegin("storeSource");
				oprot.WriteByte((byte)structs.GetStoreSource()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeSource can not be null!");
			}
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteString(structs.GetStoreId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeId can not be null!");
			}
			
			
			if(structs.GetTaxRegisterNo() != null) {
				
				oprot.WriteFieldBegin("taxRegisterNo");
				oprot.WriteString(structs.GetTaxRegisterNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetTrusteeshipInfoRequestModel bean){
			
			
		}
		
	}
	
}