using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.activity{
	
	
	
	public class CouponDataHelper : TBeanSerializer<CouponData>
	{
		
		public static CouponDataHelper OBJ = new CouponDataHelper();
		
		public static CouponDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("error_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetError_code(value);
					}
					
					
					
					
					
					if ("error_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetError_msg(value);
					}
					
					
					
					
					
					if ("coupons".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.activity.Coupon> value;
						
						value = new List<vipapis.activity.Coupon>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.activity.Coupon elem0;
								
								elem0 = new vipapis.activity.Coupon();
								vipapis.activity.CouponHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCoupons(value);
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
		
		
		public void Write(CouponData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetError_code() != null) {
				
				oprot.WriteFieldBegin("error_code");
				oprot.WriteString(structs.GetError_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetError_msg() != null) {
				
				oprot.WriteFieldBegin("error_msg");
				oprot.WriteString(structs.GetError_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupons() != null) {
				
				oprot.WriteFieldBegin("coupons");
				
				oprot.WriteListBegin();
				foreach(vipapis.activity.Coupon _item0 in structs.GetCoupons()){
					
					
					vipapis.activity.CouponHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponData bean){
			
			
		}
		
	}
	
}