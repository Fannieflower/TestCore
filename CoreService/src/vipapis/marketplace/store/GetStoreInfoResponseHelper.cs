using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.store{
	
	
	
	public class GetStoreInfoResponseHelper : TBeanSerializer<GetStoreInfoResponse>
	{
		
		public static GetStoreInfoResponseHelper OBJ = new GetStoreInfoResponseHelper();
		
		public static GetStoreInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetStoreInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("store_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_id(value);
					}
					
					
					
					
					
					if ("seller_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeller_id(value);
					}
					
					
					
					
					
					if ("store_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_name(value);
					}
					
					
					
					
					
					if ("store_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_status(value);
					}
					
					
					
					
					
					if ("store_logo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_logo(value);
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
		
		
		public void Write(GetStoreInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStore_id() != null) {
				
				oprot.WriteFieldBegin("store_id");
				oprot.WriteString(structs.GetStore_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeller_id() != null) {
				
				oprot.WriteFieldBegin("seller_id");
				oprot.WriteString(structs.GetSeller_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStore_name() != null) {
				
				oprot.WriteFieldBegin("store_name");
				oprot.WriteString(structs.GetStore_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStore_status() != null) {
				
				oprot.WriteFieldBegin("store_status");
				oprot.WriteString(structs.GetStore_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStore_logo() != null) {
				
				oprot.WriteFieldBegin("store_logo");
				oprot.WriteString(structs.GetStore_logo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetStoreInfoResponse bean){
			
			
		}
		
	}
	
}