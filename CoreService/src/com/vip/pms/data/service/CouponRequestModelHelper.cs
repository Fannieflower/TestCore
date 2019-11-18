using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponRequestModelHelper : TBeanSerializer<CouponRequestModel>
	{
		
		public static CouponRequestModelHelper OBJ = new CouponRequestModelHelper();
		
		public static CouponRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.CouponCoreModel value;
						
						value = new com.vip.pms.data.service.CouponCoreModel();
						com.vip.pms.data.service.CouponCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetCouponCoreModel(value);
					}
					
					
					
					
					
					if ("couponGroupCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.CouponGroupCoreModel value;
						
						value = new com.vip.pms.data.service.CouponGroupCoreModel();
						com.vip.pms.data.service.CouponGroupCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetCouponGroupCoreModel(value);
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
		
		
		public void Write(CouponRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponCoreModel() != null) {
				
				oprot.WriteFieldBegin("couponCoreModel");
				
				com.vip.pms.data.service.CouponCoreModelHelper.getInstance().Write(structs.GetCouponCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCouponGroupCoreModel() != null) {
				
				oprot.WriteFieldBegin("couponGroupCoreModel");
				
				com.vip.pms.data.service.CouponGroupCoreModelHelper.getInstance().Write(structs.GetCouponGroupCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponRequestModel bean){
			
			
		}
		
	}
	
}