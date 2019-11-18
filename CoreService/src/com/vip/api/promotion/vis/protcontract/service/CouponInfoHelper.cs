using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class CouponInfoHelper : TBeanSerializer<CouponInfo>
	{
		
		public static CouponInfoHelper OBJ = new CouponInfoHelper();
		
		public static CouponInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMainId(value);
					}
					
					
					
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("redMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRedMoney(value);
					}
					
					
					
					
					
					if ("redNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRedNum(value);
					}
					
					
					
					
					
					if ("fullMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullMoney(value);
					}
					
					
					
					
					
					if ("vendorBearInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.VendorBearInfo();
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetVendorBearInfo(value);
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
		
		
		public void Write(CouponInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainId() != null) {
				
				oprot.WriteFieldBegin("mainId");
				oprot.WriteI64((long)structs.GetMainId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRedMoney() != null) {
				
				oprot.WriteFieldBegin("redMoney");
				oprot.WriteString(structs.GetRedMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRedNum() != null) {
				
				oprot.WriteFieldBegin("redNum");
				oprot.WriteI32((int)structs.GetRedNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullMoney() != null) {
				
				oprot.WriteFieldBegin("fullMoney");
				oprot.WriteString(structs.GetFullMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorBearInfo() != null) {
				
				oprot.WriteFieldBegin("vendorBearInfo");
				
				com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Write(structs.GetVendorBearInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponInfo bean){
			
			
		}
		
	}
	
}