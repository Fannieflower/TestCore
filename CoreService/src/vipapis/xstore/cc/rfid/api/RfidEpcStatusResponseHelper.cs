using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.rfid.api{
	
	
	
	public class RfidEpcStatusResponseHelper : TBeanSerializer<RfidEpcStatusResponse>
	{
		
		public static RfidEpcStatusResponseHelper OBJ = new RfidEpcStatusResponseHelper();
		
		public static RfidEpcStatusResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RfidEpcStatusResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("oldBarcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldBarcode(value);
					}
					
					
					
					
					
					if ("newBarcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNewBarcode(value);
					}
					
					
					
					
					
					if ("owner".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOwner(value);
					}
					
					
					
					
					
					if ("extCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtCode(value);
					}
					
					
					
					
					
					if ("epc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEpc(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
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
		
		
		public void Write(RfidEpcStatusResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOldBarcode() != null) {
				
				oprot.WriteFieldBegin("oldBarcode");
				oprot.WriteString(structs.GetOldBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("oldBarcode can not be null!");
			}
			
			
			if(structs.GetNewBarcode() != null) {
				
				oprot.WriteFieldBegin("newBarcode");
				oprot.WriteString(structs.GetNewBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("newBarcode can not be null!");
			}
			
			
			if(structs.GetOwner() != null) {
				
				oprot.WriteFieldBegin("owner");
				oprot.WriteString(structs.GetOwner());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("owner can not be null!");
			}
			
			
			if(structs.GetExtCode() != null) {
				
				oprot.WriteFieldBegin("extCode");
				oprot.WriteString(structs.GetExtCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("extCode can not be null!");
			}
			
			
			if(structs.GetEpc() != null) {
				
				oprot.WriteFieldBegin("epc");
				oprot.WriteString(structs.GetEpc());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("epc can not be null!");
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("createTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RfidEpcStatusResponse bean){
			
			
		}
		
	}
	
}