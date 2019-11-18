using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsSpecialFavModelHelper : TBeanSerializer<PmsSpecialFavModel>
	{
		
		public static PmsSpecialFavModelHelper OBJ = new PmsSpecialFavModelHelper();
		
		public static PmsSpecialFavModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsSpecialFavModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("customerLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerLevel(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetDiscount(value);
					}
					
					
					
					
					
					if ("favorable".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFavorable(value);
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
		
		
		public void Write(PmsSpecialFavModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCustomerLevel() != null) {
				
				oprot.WriteFieldBegin("customerLevel");
				oprot.WriteString(structs.GetCustomerLevel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customerLevel can not be null!");
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteDouble((double)structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFavorable() != null) {
				
				oprot.WriteFieldBegin("favorable");
				oprot.WriteDouble((double)structs.GetFavorable());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsSpecialFavModel bean){
			
			
		}
		
	}
	
}