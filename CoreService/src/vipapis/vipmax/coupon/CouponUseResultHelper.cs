using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.coupon{
	
	
	
	public class CouponUseResultHelper : TBeanSerializer<CouponUseResult>
	{
		
		public static CouponUseResultHelper OBJ = new CouponUseResultHelper();
		
		public static CouponUseResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponUseResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("coupon_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCoupon_type(value);
					}
					
					
					
					
					
					if ("coupon_field".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCoupon_field(value);
					}
					
					
					
					
					
					if ("coupon_type_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCoupon_type_name(value);
					}
					
					
					
					
					
					if ("coupon_fav_desc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCoupon_fav_desc(value);
					}
					
					
					
					
					
					if ("sku_ids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSku_ids(value);
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
		
		
		public void Write(CouponUseResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCoupon_sn() != null) {
				
				oprot.WriteFieldBegin("coupon_sn");
				oprot.WriteString(structs.GetCoupon_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupon_type() != null) {
				
				oprot.WriteFieldBegin("coupon_type");
				oprot.WriteI32((int)structs.GetCoupon_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupon_field() != null) {
				
				oprot.WriteFieldBegin("coupon_field");
				oprot.WriteI32((int)structs.GetCoupon_field()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupon_type_name() != null) {
				
				oprot.WriteFieldBegin("coupon_type_name");
				oprot.WriteString(structs.GetCoupon_type_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupon_fav_desc() != null) {
				
				oprot.WriteFieldBegin("coupon_fav_desc");
				oprot.WriteString(structs.GetCoupon_fav_desc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSku_ids() != null) {
				
				oprot.WriteFieldBegin("sku_ids");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSku_ids()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponUseResult bean){
			
			
		}
		
	}
	
}