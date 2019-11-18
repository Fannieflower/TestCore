using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.jingdong{
	
	
	
	public class PromCouponInfoHelper : TBeanSerializer<PromCouponInfo>
	{
		
		public static PromCouponInfoHelper OBJ = new PromCouponInfoHelper();
		
		public static PromCouponInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PromCouponInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
		
		
		public void Write(PromCouponInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCoupon_sn() != null) {
				
				oprot.WriteFieldBegin("coupon_sn");
				oprot.WriteString(structs.GetCoupon_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PromCouponInfo bean){
			
			
		}
		
	}
	
}