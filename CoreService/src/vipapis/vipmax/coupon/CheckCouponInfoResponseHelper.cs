using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.coupon{
	
	
	
	public class CheckCouponInfoResponseHelper : TBeanSerializer<CheckCouponInfoResponse>
	{
		
		public static CheckCouponInfoResponseHelper OBJ = new CheckCouponInfoResponseHelper();
		
		public static CheckCouponInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CheckCouponInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total_fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTotal_fav(value);
					}
					
					
					
					
					
					if ("alloc_fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, string> value;
						
						value = new Dictionary<string, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								string _val0;
								_key0 = iprot.ReadString();
								
								_val0 = iprot.ReadString();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetAlloc_fav(value);
					}
					
					
					
					
					
					if ("coupons".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.coupon.CouponCheckResult> value;
						
						value = new List<vipapis.vipmax.coupon.CouponCheckResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.coupon.CouponCheckResult elem1;
								
								elem1 = new vipapis.vipmax.coupon.CouponCheckResult();
								vipapis.vipmax.coupon.CouponCheckResultHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
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
		
		
		public void Write(CheckCouponInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal_fav() != null) {
				
				oprot.WriteFieldBegin("total_fav");
				oprot.WriteString(structs.GetTotal_fav());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAlloc_fav() != null) {
				
				oprot.WriteFieldBegin("alloc_fav");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, string > _ir0 in structs.GetAlloc_fav()){
					
					string _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCoupons() != null) {
				
				oprot.WriteFieldBegin("coupons");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.coupon.CouponCheckResult _item0 in structs.GetCoupons()){
					
					
					vipapis.vipmax.coupon.CouponCheckResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CheckCouponInfoResponse bean){
			
			
		}
		
	}
	
}