using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponRuleRequestModelHelper : TBeanSerializer<CouponRuleRequestModel>
	{
		
		public static CouponRuleRequestModelHelper OBJ = new CouponRuleRequestModelHelper();
		
		public static CouponRuleRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponRuleRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponRuleCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.CouponRuleCoreModel value;
						
						value = new com.vip.pms.data.service.CouponRuleCoreModel();
						com.vip.pms.data.service.CouponRuleCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetCouponRuleCoreModel(value);
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
		
		
		public void Write(CouponRuleRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponRuleCoreModel() != null) {
				
				oprot.WriteFieldBegin("couponRuleCoreModel");
				
				com.vip.pms.data.service.CouponRuleCoreModelHelper.getInstance().Write(structs.GetCouponRuleCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponRuleCoreModel can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponRuleRequestModel bean){
			
			
		}
		
	}
	
}