using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PoGroupHelper : TBeanSerializer<PoGroup>
	{
		
		public static PoGroupHelper OBJ = new PoGroupHelper();
		
		public static PoGroupHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoGroup structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchaseQuantity(value);
					}
					
					
					
					
					
					if ("avgAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetAvgAmount(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmount(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetDiscount(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("seasonName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeasonName(value);
					}
					
					
					
					
					
					if ("subCategoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubCategoryId(value);
					}
					
					
					
					
					
					if ("subCategoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubCategoryName(value);
					}
					
					
					
					
					
					if ("leafCategoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLeafCategoryId(value);
					}
					
					
					
					
					
					if ("leafCategoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLeafCategoryName(value);
					}
					
					
					
					
					
					if ("season".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeason(value);
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
		
		
		public void Write(PoGroup structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseQuantity() != null) {
				
				oprot.WriteFieldBegin("purchaseQuantity");
				oprot.WriteI32((int)structs.GetPurchaseQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseQuantity can not be null!");
			}
			
			
			if(structs.GetAvgAmount() != null) {
				
				oprot.WriteFieldBegin("avgAmount");
				oprot.WriteDouble((double)structs.GetAvgAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("avgAmount can not be null!");
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteDouble((double)structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalAmount can not be null!");
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteDouble((double)structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("discount can not be null!");
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeasonName() != null) {
				
				oprot.WriteFieldBegin("seasonName");
				oprot.WriteString(structs.GetSeasonName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubCategoryId() != null) {
				
				oprot.WriteFieldBegin("subCategoryId");
				oprot.WriteString(structs.GetSubCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubCategoryName() != null) {
				
				oprot.WriteFieldBegin("subCategoryName");
				oprot.WriteString(structs.GetSubCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLeafCategoryId() != null) {
				
				oprot.WriteFieldBegin("leafCategoryId");
				oprot.WriteString(structs.GetLeafCategoryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLeafCategoryName() != null) {
				
				oprot.WriteFieldBegin("leafCategoryName");
				oprot.WriteString(structs.GetLeafCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeason() != null) {
				
				oprot.WriteFieldBegin("season");
				oprot.WriteString(structs.GetSeason());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoGroup bean){
			
			
		}
		
	}
	
}