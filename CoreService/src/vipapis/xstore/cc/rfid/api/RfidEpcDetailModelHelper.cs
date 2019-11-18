using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.rfid.api{
	
	
	
	public class RfidEpcDetailModelHelper : TBeanSerializer<RfidEpcDetailModel>
	{
		
		public static RfidEpcDetailModelHelper OBJ = new RfidEpcDetailModelHelper();
		
		public static RfidEpcDetailModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RfidEpcDetailModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("epc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEpc(value);
					}
					
					
					
					
					
					if ("cazeNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCazeNo(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
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
		
		
		public void Write(RfidEpcDetailModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetEpc() != null) {
				
				oprot.WriteFieldBegin("epc");
				oprot.WriteString(structs.GetEpc());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("epc can not be null!");
			}
			
			
			if(structs.GetCazeNo() != null) {
				
				oprot.WriteFieldBegin("cazeNo");
				oprot.WriteString(structs.GetCazeNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cazeNo can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RfidEpcDetailModel bean){
			
			
		}
		
	}
	
}