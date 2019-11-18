using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.puma{
	
	
	
	public class ProductQueryRequestHelper : TBeanSerializer<ProductQueryRequest>
	{
		
		public static ProductQueryRequestHelper OBJ = new ProductQueryRequestHelper();
		
		public static ProductQueryRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductQueryRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.puma.Pagination value;
						
						value = new vipapis.puma.Pagination();
						vipapis.puma.PaginationHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
					}
					
					
					
					
					
					if ("product_ids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								long elem1;
								elem1 = iprot.ReadI64(); 
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetProduct_ids(value);
					}
					
					
					
					
					
					if ("brand_sns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								string elem2;
								elem2 = iprot.ReadString();
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetBrand_sns(value);
					}
					
					
					
					
					
					if ("third_level_category_ids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								int elem3;
								elem3 = iprot.ReadI32(); 
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetThird_level_category_ids(value);
					}
					
					
					
					
					
					if ("query_types".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								int elem4;
								elem4 = iprot.ReadI32(); 
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetQuery_types(value);
					}
					
					
					
					
					
					if ("is_on_sale".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIs_on_sale(value);
					}
					
					
					
					
					
					if ("product_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProduct_name(value);
					}
					
					
					
					
					
					if ("price_ranges".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.puma.NumberRange> value;
						
						value = new List<vipapis.puma.NumberRange>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								vipapis.puma.NumberRange elem5;
								
								elem5 = new vipapis.puma.NumberRange();
								vipapis.puma.NumberRangeHelper.getInstance().Read(elem5, iprot);
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetPrice_ranges(value);
					}
					
					
					
					
					
					if ("product_tags".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								int elem7;
								elem7 = iprot.ReadI32(); 
								
								value.Add(elem7);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetProduct_tags(value);
					}
					
					
					
					
					
					if ("sort_attres".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.puma.SortAttr> value;
						
						value = new List<vipapis.puma.SortAttr>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								vipapis.puma.SortAttr elem8;
								
								elem8 = new vipapis.puma.SortAttr();
								vipapis.puma.SortAttrHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetSort_attres(value);
					}
					
					
					
					
					
					if ("discount_ranges".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.puma.NumberRange> value;
						
						value = new List<vipapis.puma.NumberRange>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								vipapis.puma.NumberRange elem10;
								
								elem10 = new vipapis.puma.NumberRange();
								vipapis.puma.NumberRangeHelper.getInstance().Read(elem10, iprot);
								
								value.Add(elem10);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetDiscount_ranges(value);
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
		
		
		public void Write(ProductQueryRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				vipapis.puma.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pagination can not be null!");
			}
			
			
			if(structs.GetProduct_ids() != null) {
				
				oprot.WriteFieldBegin("product_ids");
				
				oprot.WriteSetBegin();
				foreach(long _item0 in structs.GetProduct_ids()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_sns() != null) {
				
				oprot.WriteFieldBegin("brand_sns");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetBrand_sns()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThird_level_category_ids() != null) {
				
				oprot.WriteFieldBegin("third_level_category_ids");
				
				oprot.WriteSetBegin();
				foreach(int _item0 in structs.GetThird_level_category_ids()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuery_types() != null) {
				
				oprot.WriteFieldBegin("query_types");
				
				oprot.WriteSetBegin();
				foreach(int _item0 in structs.GetQuery_types()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("query_types can not be null!");
			}
			
			
			if(structs.GetIs_on_sale() != null) {
				
				oprot.WriteFieldBegin("is_on_sale");
				oprot.WriteI32((int)structs.GetIs_on_sale()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProduct_name() != null) {
				
				oprot.WriteFieldBegin("product_name");
				oprot.WriteString(structs.GetProduct_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrice_ranges() != null) {
				
				oprot.WriteFieldBegin("price_ranges");
				
				oprot.WriteSetBegin();
				foreach(vipapis.puma.NumberRange _item0 in structs.GetPrice_ranges()){
					
					
					vipapis.puma.NumberRangeHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProduct_tags() != null) {
				
				oprot.WriteFieldBegin("product_tags");
				
				oprot.WriteSetBegin();
				foreach(int _item0 in structs.GetProduct_tags()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSort_attres() != null) {
				
				oprot.WriteFieldBegin("sort_attres");
				
				oprot.WriteSetBegin();
				foreach(vipapis.puma.SortAttr _item0 in structs.GetSort_attres()){
					
					
					vipapis.puma.SortAttrHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscount_ranges() != null) {
				
				oprot.WriteFieldBegin("discount_ranges");
				
				oprot.WriteSetBegin();
				foreach(vipapis.puma.NumberRange _item0 in structs.GetDiscount_ranges()){
					
					
					vipapis.puma.NumberRangeHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductQueryRequest bean){
			
			
		}
		
	}
	
}