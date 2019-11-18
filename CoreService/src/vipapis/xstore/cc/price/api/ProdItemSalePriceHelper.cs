using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class ProdItemSalePriceHelper : TBeanSerializer<ProdItemSalePrice>
	{
		
		public static ProdItemSalePriceHelper OBJ = new ProdItemSalePriceHelper();
		
		public static ProdItemSalePriceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdItemSalePrice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sale_price_change_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSale_price_change_no(value);
					}
					
					
					
					
					
					if ("store_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_code(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("suggestion_retail_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSuggestion_retail_price(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscount(value);
					}
					
					
					
					
					
					if ("sale_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSale_price(value);
					}
					
					
					
					
					
					if ("start_effective_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStart_effective_time(value);
					}
					
					
					
					
					
					if ("end_effective_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEnd_effective_time(value);
					}
					
					
					
					
					
					if ("is_global".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_global(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreate_time(value);
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
		
		
		public void Write(ProdItemSalePrice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSale_price_change_no() != null) {
				
				oprot.WriteFieldBegin("sale_price_change_no");
				oprot.WriteString(structs.GetSale_price_change_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStore_code() != null) {
				
				oprot.WriteFieldBegin("store_code");
				oprot.WriteString(structs.GetStore_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuggestion_retail_price() != null) {
				
				oprot.WriteFieldBegin("suggestion_retail_price");
				oprot.WriteString(structs.GetSuggestion_retail_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteString(structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSale_price() != null) {
				
				oprot.WriteFieldBegin("sale_price");
				oprot.WriteString(structs.GetSale_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStart_effective_time() != null) {
				
				oprot.WriteFieldBegin("start_effective_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_effective_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnd_effective_time() != null) {
				
				oprot.WriteFieldBegin("end_effective_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_effective_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_global() != null) {
				
				oprot.WriteFieldBegin("is_global");
				oprot.WriteBool((bool)structs.GetIs_global());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdItemSalePrice bean){
			
			
		}
		
	}
	
}