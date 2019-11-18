using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponOrderRequestModelHelper : TBeanSerializer<CouponOrderRequestModel>
	{
		
		public static CouponOrderRequestModelHelper OBJ = new CouponOrderRequestModelHelper();
		
		public static CouponOrderRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponOrderRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponUserList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponUserLogRequestModel> value;
						
						value = new List<com.vip.pms.data.service.CouponUserLogRequestModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponUserLogRequestModel elem0;
								
								elem0 = new com.vip.pms.data.service.CouponUserLogRequestModel();
								com.vip.pms.data.service.CouponUserLogRequestModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCouponUserList(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
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
		
		
		public void Write(CouponOrderRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponUserList() != null) {
				
				oprot.WriteFieldBegin("couponUserList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponUserLogRequestModel _item0 in structs.GetCouponUserList()){
					
					
					com.vip.pms.data.service.CouponUserLogRequestModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponUserList can not be null!");
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponOrderRequestModel bean){
			
			
		}
		
	}
	
}