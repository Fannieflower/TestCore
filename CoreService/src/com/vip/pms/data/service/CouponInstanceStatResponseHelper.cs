using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponInstanceStatResponseHelper : TBeanSerializer<CouponInstanceStatResponse>
	{
		
		public static CouponInstanceStatResponseHelper OBJ = new CouponInstanceStatResponseHelper();
		
		public static CouponInstanceStatResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponInstanceStatResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponNo(value);
					}
					
					
					
					
					
					if ("activatedAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetActivatedAmount(value);
					}
					
					
					
					
					
					if ("usedAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUsedAmount(value);
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
		
		
		public void Write(CouponInstanceStatResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponNo() != null) {
				
				oprot.WriteFieldBegin("couponNo");
				oprot.WriteString(structs.GetCouponNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponNo can not be null!");
			}
			
			
			if(structs.GetActivatedAmount() != null) {
				
				oprot.WriteFieldBegin("activatedAmount");
				oprot.WriteI64((long)structs.GetActivatedAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activatedAmount can not be null!");
			}
			
			
			if(structs.GetUsedAmount() != null) {
				
				oprot.WriteFieldBegin("usedAmount");
				oprot.WriteI64((long)structs.GetUsedAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("usedAmount can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponInstanceStatResponse bean){
			
			
		}
		
	}
	
}