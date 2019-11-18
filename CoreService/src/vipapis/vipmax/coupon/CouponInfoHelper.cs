using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.coupon{
	
	
	
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
					
					
					if ("seq".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSeq(value);
					}
					
					
					
					
					
					if ("coupon_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCoupon_sn(value);
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
			
			if(structs.GetSeq() != null) {
				
				oprot.WriteFieldBegin("seq");
				oprot.WriteI32((int)structs.GetSeq()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seq can not be null!");
			}
			
			
			if(structs.GetCoupon_sn() != null) {
				
				oprot.WriteFieldBegin("coupon_sn");
				oprot.WriteString(structs.GetCoupon_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("coupon_sn can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponInfo bean){
			
			
		}
		
	}
	
}