using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.rfid.api{
	
	
	
	public class RfidDataRequestHelper : TBeanSerializer<RfidDataRequest>
	{
		
		public static RfidDataRequestHelper OBJ = new RfidDataRequestHelper();
		
		public static RfidDataRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RfidDataRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("rfid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRfid(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("owner".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOwner(value);
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
		
		
		public void Write(RfidDataRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRfid() != null) {
				
				oprot.WriteFieldBegin("rfid");
				oprot.WriteString(structs.GetRfid());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rfid can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetOwner() != null) {
				
				oprot.WriteFieldBegin("owner");
				oprot.WriteString(structs.GetOwner());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("owner can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RfidDataRequest bean){
			
			
		}
		
	}
	
}