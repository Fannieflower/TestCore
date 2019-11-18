using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.product{
	
	
	
	public class SpuHelper : TBeanSerializer<Spu>
	{
		
		public static SpuHelper OBJ = new SpuHelper();
		
		public static SpuHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Spu structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("ean".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEan(value);
					}
					
					
					
					
					
					if ("isOnline".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsOnline(value);
					}
					
					
					
					
					
					if ("unit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnit(value);
					}
					
					
					
					
					
					if ("upc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpc(value);
					}
					
					
					
					
					
					if ("productName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductName(value);
					}
					
					
					
					
					
					if ("categoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryId(value);
					}
					
					
					
					
					
					if ("stepQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStepQuantity(value);
					}
					
					
					
					
					
					if ("shortDescription".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShortDescription(value);
					}
					
					
					
					
					
					if ("longDescription".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLongDescription(value);
					}
					
					
					
					
					
					if ("minOrderQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMinOrderQuantity(value);
					}
					
					
					
					
					
					if ("isSearchable".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsSearchable(value);
					}
					
					
					
					
					
					if ("taxClassId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxClassId(value);
					}
					
					
					
					
					
					if ("isAvailable".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsAvailable(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("brand".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand(value);
					}
					
					
					
					
					
					if ("variations".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVariations(value);
					}
					
					
					
					
					
					if ("sftpFileLogId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSftpFileLogId(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
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
		
		
		public void Write(Spu structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetEan() != null) {
				
				oprot.WriteFieldBegin("ean");
				oprot.WriteString(structs.GetEan());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsOnline() != null) {
				
				oprot.WriteFieldBegin("isOnline");
				oprot.WriteByte((byte)structs.GetIsOnline()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnit() != null) {
				
				oprot.WriteFieldBegin("unit");
				oprot.WriteString(structs.GetUnit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpc() != null) {
				
				oprot.WriteFieldBegin("upc");
				oprot.WriteString(structs.GetUpc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductName() != null) {
				
				oprot.WriteFieldBegin("productName");
				oprot.WriteString(structs.GetProductName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryId() != null) {
				
				oprot.WriteFieldBegin("categoryId");
				oprot.WriteString(structs.GetCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStepQuantity() != null) {
				
				oprot.WriteFieldBegin("stepQuantity");
				oprot.WriteString(structs.GetStepQuantity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShortDescription() != null) {
				
				oprot.WriteFieldBegin("shortDescription");
				oprot.WriteString(structs.GetShortDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLongDescription() != null) {
				
				oprot.WriteFieldBegin("longDescription");
				oprot.WriteString(structs.GetLongDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMinOrderQuantity() != null) {
				
				oprot.WriteFieldBegin("minOrderQuantity");
				oprot.WriteI32((int)structs.GetMinOrderQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSearchable() != null) {
				
				oprot.WriteFieldBegin("isSearchable");
				oprot.WriteByte((byte)structs.GetIsSearchable()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxClassId() != null) {
				
				oprot.WriteFieldBegin("taxClassId");
				oprot.WriteString(structs.GetTaxClassId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsAvailable() != null) {
				
				oprot.WriteFieldBegin("isAvailable");
				oprot.WriteByte((byte)structs.GetIsAvailable()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteByte((byte)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand() != null) {
				
				oprot.WriteFieldBegin("brand");
				oprot.WriteString(structs.GetBrand());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVariations() != null) {
				
				oprot.WriteFieldBegin("variations");
				oprot.WriteString(structs.GetVariations());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSftpFileLogId() != null) {
				
				oprot.WriteFieldBegin("sftpFileLogId");
				oprot.WriteString(structs.GetSftpFileLogId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteByte((byte)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Spu bean){
			
			
		}
		
	}
	
}