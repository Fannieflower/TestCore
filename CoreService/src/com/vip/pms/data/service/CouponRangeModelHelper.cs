using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponRangeModelHelper : TBeanSerializer<CouponRangeModel>
	{
		
		public static CouponRangeModelHelper OBJ = new CouponRangeModelHelper();
		
		public static CouponRangeModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponRangeModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("rangeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRangeName(value);
					}
					
					
					
					
					
					if ("rangeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRangeId(value);
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
		
		
		public void Write(CouponRangeModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRangeName() != null) {
				
				oprot.WriteFieldBegin("rangeName");
				oprot.WriteString(structs.GetRangeName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rangeName can not be null!");
			}
			
			
			if(structs.GetRangeId() != null) {
				
				oprot.WriteFieldBegin("rangeId");
				oprot.WriteString(structs.GetRangeId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rangeId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponRangeModel bean){
			
			
		}
		
	}
	
}