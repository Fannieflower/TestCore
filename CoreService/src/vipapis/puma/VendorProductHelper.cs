using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.puma{
	
	
	
	public class VendorProductHelper : TBeanSerializer<VendorProduct>
	{
		
		public static VendorProductHelper OBJ = new VendorProductHelper();
		
		public static VendorProductHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorProduct structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTitle(value);
					}
					
					
					
					
					
					if ("image_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetImage_url(value);
					}
					
					
					
					
					
					if ("product_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetProduct_type(value);
					}
					
					
					
					
					
					if ("brand_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand_id(value);
					}
					
					
					
					
					
					if ("brand_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand_name(value);
					}
					
					
					
					
					
					if ("brand_cn_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand_cn_name(value);
					}
					
					
					
					
					
					if ("brand_en_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand_en_name(value);
					}
					
					
					
					
					
					if ("third_level_category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThird_level_category_id(value);
					}
					
					
					
					
					
					if ("third_level_category_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetThird_level_category_name(value);
					}
					
					
					
					
					
					if ("square_images".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<int?, string> value;
						
						value = new Dictionary<int?, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								int _key0;
								string _val0;
								_key0 = iprot.ReadI32(); 
								
								_val0 = iprot.ReadString();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetSquare_images(value);
					}
					
					
					
					
					
					if ("rectangle_images".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<int?, string> value;
						
						value = new Dictionary<int?, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								int _key1;
								string _val1;
								_key1 = iprot.ReadI32(); 
								
								_val1 = iprot.ReadString();
								
								value.Add(_key1, _val1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetRectangle_images(value);
					}
					
					
					
					
					
					if ("detailed_Images".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<int?, string> value;
						
						value = new Dictionary<int?, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								int _key2;
								string _val2;
								_key2 = iprot.ReadI32(); 
								
								_val2 = iprot.ReadString();
								
								value.Add(_key2, _val2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetDetailed_Images(value);
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
		
		
		public void Write(VendorProduct structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTitle() != null) {
				
				oprot.WriteFieldBegin("title");
				oprot.WriteString(structs.GetTitle());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_url() != null) {
				
				oprot.WriteFieldBegin("image_url");
				oprot.WriteString(structs.GetImage_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProduct_type() != null) {
				
				oprot.WriteFieldBegin("product_type");
				oprot.WriteI32((int)structs.GetProduct_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_id() != null) {
				
				oprot.WriteFieldBegin("brand_id");
				oprot.WriteString(structs.GetBrand_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_name() != null) {
				
				oprot.WriteFieldBegin("brand_name");
				oprot.WriteString(structs.GetBrand_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_cn_name() != null) {
				
				oprot.WriteFieldBegin("brand_cn_name");
				oprot.WriteString(structs.GetBrand_cn_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_en_name() != null) {
				
				oprot.WriteFieldBegin("brand_en_name");
				oprot.WriteString(structs.GetBrand_en_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThird_level_category_id() != null) {
				
				oprot.WriteFieldBegin("third_level_category_id");
				oprot.WriteI32((int)structs.GetThird_level_category_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThird_level_category_name() != null) {
				
				oprot.WriteFieldBegin("third_level_category_name");
				oprot.WriteString(structs.GetThird_level_category_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSquare_images() != null) {
				
				oprot.WriteFieldBegin("square_images");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< int?, string > _ir0 in structs.GetSquare_images()){
					
					int? _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteI32((int)_key0); 
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRectangle_images() != null) {
				
				oprot.WriteFieldBegin("rectangle_images");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< int?, string > _ir0 in structs.GetRectangle_images()){
					
					int? _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteI32((int)_key0); 
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetailed_Images() != null) {
				
				oprot.WriteFieldBegin("detailed_Images");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< int?, string > _ir0 in structs.GetDetailed_Images()){
					
					int? _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteI32((int)_key0); 
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorProduct bean){
			
			
		}
		
	}
	
}