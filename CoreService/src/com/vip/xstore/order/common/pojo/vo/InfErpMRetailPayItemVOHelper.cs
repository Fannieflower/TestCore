using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	public class InfErpMRetailPayItemVOHelper : TBeanSerializer<InfErpMRetailPayItemVO>
	{
		
		public static InfErpMRetailPayItemVOHelper OBJ = new InfErpMRetailPayItemVOHelper();
		
		public static InfErpMRetailPayItemVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InfErpMRetailPayItemVO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("mRetailId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMRetailId(value);
					}
					
					
					
					
					
					if ("cCurrencyId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCCurrencyId(value);
					}
					
					
					
					
					
					if ("cCurrency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCCurrency(value);
					}
					
					
					
					
					
					if ("cPaywayId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCPaywayId(value);
					}
					
					
					
					
					
					if ("cPayway".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCPayway(value);
					}
					
					
					
					
					
					if ("payamount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayamount(value);
					}
					
					
					
					
					
					if ("description".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDescription(value);
					}
					
					
					
					
					
					if ("rfidno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRfidno(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsDeleted(value);
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
		
		
		public void Write(InfErpMRetailPayItemVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMRetailId() != null) {
				
				oprot.WriteFieldBegin("mRetailId");
				oprot.WriteI64((long)structs.GetMRetailId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCCurrencyId() != null) {
				
				oprot.WriteFieldBegin("cCurrencyId");
				oprot.WriteI64((long)structs.GetCCurrencyId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCCurrency() != null) {
				
				oprot.WriteFieldBegin("cCurrency");
				oprot.WriteString(structs.GetCCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCPaywayId() != null) {
				
				oprot.WriteFieldBegin("cPaywayId");
				oprot.WriteI64((long)structs.GetCPaywayId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCPayway() != null) {
				
				oprot.WriteFieldBegin("cPayway");
				oprot.WriteString(structs.GetCPayway());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayamount() != null) {
				
				oprot.WriteFieldBegin("payamount");
				oprot.WriteString(structs.GetPayamount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDescription() != null) {
				
				oprot.WriteFieldBegin("description");
				oprot.WriteString(structs.GetDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRfidno() != null) {
				
				oprot.WriteFieldBegin("rfidno");
				oprot.WriteString(structs.GetRfidno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteI32((int)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InfErpMRetailPayItemVO bean){
			
			
		}
		
	}
	
}