using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.activity{
	
	
	
	public class CouponHelper : TBeanSerializer<Coupon>
	{
		
		public static CouponHelper OBJ = new CouponHelper();
		
		public static CouponHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Coupon structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("coupon_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCoupon_name(value);
					}
					
					
					
					
					
					if ("coupon_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCoupon_type(value);
					}
					
					
					
					
					
					if ("use_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUse_type(value);
					}
					
					
					
					
					
					if ("buy".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetBuy(value);
					}
					
					
					
					
					
					if ("fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFav(value);
					}
					
					
					
					
					
					if ("activate_begin_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetActivate_begin_time(value);
					}
					
					
					
					
					
					if ("activate_end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetActivate_end_time(value);
					}
					
					
					
					
					
					if ("use_relative_days".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUse_relative_days(value);
					}
					
					
					
					
					
					if ("use_begin_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUse_begin_time(value);
					}
					
					
					
					
					
					if ("use_end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUse_end_time(value);
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
		
		
		public void Write(Coupon structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCoupon_name() != null) {
				
				oprot.WriteFieldBegin("coupon_name");
				oprot.WriteString(structs.GetCoupon_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupon_type() != null) {
				
				oprot.WriteFieldBegin("coupon_type");
				oprot.WriteI32((int)structs.GetCoupon_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUse_type() != null) {
				
				oprot.WriteFieldBegin("use_type");
				oprot.WriteI32((int)structs.GetUse_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuy() != null) {
				
				oprot.WriteFieldBegin("buy");
				oprot.WriteDouble((double)structs.GetBuy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFav() != null) {
				
				oprot.WriteFieldBegin("fav");
				oprot.WriteDouble((double)structs.GetFav());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivate_begin_time() != null) {
				
				oprot.WriteFieldBegin("activate_begin_time");
				oprot.WriteI64((long)structs.GetActivate_begin_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivate_end_time() != null) {
				
				oprot.WriteFieldBegin("activate_end_time");
				oprot.WriteI64((long)structs.GetActivate_end_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUse_relative_days() != null) {
				
				oprot.WriteFieldBegin("use_relative_days");
				oprot.WriteI32((int)structs.GetUse_relative_days()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUse_begin_time() != null) {
				
				oprot.WriteFieldBegin("use_begin_time");
				oprot.WriteI64((long)structs.GetUse_begin_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUse_end_time() != null) {
				
				oprot.WriteFieldBegin("use_end_time");
				oprot.WriteI64((long)structs.GetUse_end_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Coupon bean){
			
			
		}
		
	}
	
}