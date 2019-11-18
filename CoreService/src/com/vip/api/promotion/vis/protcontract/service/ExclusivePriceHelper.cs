using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ExclusivePriceHelper : TBeanSerializer<ExclusivePrice>
	{
		
		public static ExclusivePriceHelper OBJ = new ExclusivePriceHelper();
		
		public static ExclusivePriceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExclusivePrice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMainId(value);
					}
					
					
					
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("discountContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountContent(value);
					}
					
					
					
					
					
					if ("exclusivePriceDiscounts".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.common.NameValueItem> value;
						
						value = new List<com.vip.api.promotion.vis.common.NameValueItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.common.NameValueItem elem0;
								
								elem0 = new com.vip.api.promotion.vis.common.NameValueItem();
								com.vip.api.promotion.vis.common.NameValueItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetExclusivePriceDiscounts(value);
					}
					
					
					
					
					
					if ("vendorBearInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.VendorBearInfo();
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetVendorBearInfo(value);
					}
					
					
					
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
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
		
		
		public void Write(ExclusivePrice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainId() != null) {
				
				oprot.WriteFieldBegin("mainId");
				oprot.WriteI64((long)structs.GetMainId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountContent() != null) {
				
				oprot.WriteFieldBegin("discountContent");
				oprot.WriteString(structs.GetDiscountContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExclusivePriceDiscounts() != null) {
				
				oprot.WriteFieldBegin("exclusivePriceDiscounts");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.common.NameValueItem _item0 in structs.GetExclusivePriceDiscounts()){
					
					
					com.vip.api.promotion.vis.common.NameValueItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorBearInfo() != null) {
				
				oprot.WriteFieldBegin("vendorBearInfo");
				
				com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Write(structs.GetVendorBearInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExclusivePrice bean){
			
			
		}
		
	}
	
}