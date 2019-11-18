using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class SkuDetailHelper : TBeanSerializer<SkuDetail>
	{
		
		public static SkuDetailHelper OBJ = new SkuDetailHelper();
		
		public static SkuDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SkuDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("item_images".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.ItemImage> value;
						
						value = new List<com.vip.vop.cup.api.product.ItemImage>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.ItemImage elem0;
								
								elem0 = new com.vip.vop.cup.api.product.ItemImage();
								com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItem_images(value);
					}
					
					
					
					
					
					if ("square_images".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.ItemImage> value;
						
						value = new List<com.vip.vop.cup.api.product.ItemImage>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.ItemImage elem2;
								
								elem2 = new com.vip.vop.cup.api.product.ItemImage();
								com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSquare_images(value);
					}
					
					
					
					
					
					if ("color".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetColor(value);
					}
					
					
					
					
					
					if ("size".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSize(value);
					}
					
					
					
					
					
					if ("prod_spu_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProd_spu_id(value);
					}
					
					
					
					
					
					if ("size_detail_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSize_detail_id(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("gsn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGsn(value);
					}
					
					
					
					
					
					if ("is_expiration_management".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIs_expiration_management(value);
					}
					
					
					
					
					
					if ("expiration_days".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetExpiration_days(value);
					}
					
					
					
					
					
					if ("acceptance_deadline".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAcceptance_deadline(value);
					}
					
					
					
					
					
					if ("sale_deadline".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSale_deadline(value);
					}
					
					
					
					
					
					if ("insurance_days".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetInsurance_days(value);
					}
					
					
					
					
					
					if ("made_in".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMade_in(value);
					}
					
					
					
					
					
					if ("is_sequence_management".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIs_sequence_management(value);
					}
					
					
					
					
					
					if ("support_return".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSupport_return(value);
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
		
		
		public void Write(SkuDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItem_images() != null) {
				
				oprot.WriteFieldBegin("item_images");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.ItemImage _item0 in structs.GetItem_images()){
					
					
					com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSquare_images() != null) {
				
				oprot.WriteFieldBegin("square_images");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.ItemImage _item0 in structs.GetSquare_images()){
					
					
					com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetColor() != null) {
				
				oprot.WriteFieldBegin("color");
				oprot.WriteString(structs.GetColor());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize() != null) {
				
				oprot.WriteFieldBegin("size");
				oprot.WriteString(structs.GetSize());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProd_spu_id() != null) {
				
				oprot.WriteFieldBegin("prod_spu_id");
				oprot.WriteString(structs.GetProd_spu_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_detail_id() != null) {
				
				oprot.WriteFieldBegin("size_detail_id");
				oprot.WriteI64((long)structs.GetSize_detail_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGsn() != null) {
				
				oprot.WriteFieldBegin("gsn");
				oprot.WriteString(structs.GetGsn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_expiration_management() != null) {
				
				oprot.WriteFieldBegin("is_expiration_management");
				oprot.WriteString(structs.GetIs_expiration_management());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpiration_days() != null) {
				
				oprot.WriteFieldBegin("expiration_days");
				oprot.WriteI32((int)structs.GetExpiration_days()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptance_deadline() != null) {
				
				oprot.WriteFieldBegin("acceptance_deadline");
				oprot.WriteI32((int)structs.GetAcceptance_deadline()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSale_deadline() != null) {
				
				oprot.WriteFieldBegin("sale_deadline");
				oprot.WriteI32((int)structs.GetSale_deadline()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInsurance_days() != null) {
				
				oprot.WriteFieldBegin("insurance_days");
				oprot.WriteI32((int)structs.GetInsurance_days()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMade_in() != null) {
				
				oprot.WriteFieldBegin("made_in");
				oprot.WriteI32((int)structs.GetMade_in()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_sequence_management() != null) {
				
				oprot.WriteFieldBegin("is_sequence_management");
				oprot.WriteString(structs.GetIs_sequence_management());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSupport_return() != null) {
				
				oprot.WriteFieldBegin("support_return");
				oprot.WriteI32((int)structs.GetSupport_return()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SkuDetail bean){
			
			
		}
		
	}
	
}