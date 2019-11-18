using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActGiftInfoModelHelper : TBeanSerializer<PmsActGiftInfoModel>
	{
		
		public static PmsActGiftInfoModelHelper OBJ = new PmsActGiftInfoModelHelper();
		
		public static PmsActGiftInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActGiftInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("giftId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGiftId(value);
					}
					
					
					
					
					
					if ("giftNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGiftNum(value);
					}
					
					
					
					
					
					if ("giftName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGiftName(value);
					}
					
					
					
					
					
					if ("buyValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBuyValue(value);
					}
					
					
					
					
					
					if ("giftDetail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGiftDetail(value);
					}
					
					
					
					
					
					if ("price".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPrice(value);
					}
					
					
					
					
					
					if ("merItemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMerItemNo(value);
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
		
		
		public void Write(PmsActGiftInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGiftId() != null) {
				
				oprot.WriteFieldBegin("giftId");
				oprot.WriteI32((int)structs.GetGiftId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giftId can not be null!");
			}
			
			
			if(structs.GetGiftNum() != null) {
				
				oprot.WriteFieldBegin("giftNum");
				oprot.WriteI32((int)structs.GetGiftNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giftNum can not be null!");
			}
			
			
			if(structs.GetGiftName() != null) {
				
				oprot.WriteFieldBegin("giftName");
				oprot.WriteString(structs.GetGiftName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giftName can not be null!");
			}
			
			
			if(structs.GetBuyValue() != null) {
				
				oprot.WriteFieldBegin("buyValue");
				oprot.WriteI32((int)structs.GetBuyValue()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGiftDetail() != null) {
				
				oprot.WriteFieldBegin("giftDetail");
				oprot.WriteString(structs.GetGiftDetail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrice() != null) {
				
				oprot.WriteFieldBegin("price");
				oprot.WriteDouble((double)structs.GetPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMerItemNo() != null) {
				
				oprot.WriteFieldBegin("merItemNo");
				oprot.WriteI64((long)structs.GetMerItemNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActGiftInfoModel bean){
			
			
		}
		
	}
	
}