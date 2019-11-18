using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class SpuDetailHelper : TBeanSerializer<SpuDetail>
	{
		
		public static SpuDetailHelper OBJ = new SpuDetailHelper();
		
		public static SpuDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpuDetail structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("short_video".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShort_video(value);
					}
					
					
					
					
					
					if ("long_video".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLong_video(value);
					}
					
					
					
					
					
					if ("sub_title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSub_title(value);
					}
					
					
					
					
					
					if ("category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCategory_id(value);
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
					
					
					
					
					
					if ("length".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLength(value);
					}
					
					
					
					
					
					if ("width".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetWidth(value);
					}
					
					
					
					
					
					if ("height".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetHeight(value);
					}
					
					
					
					
					
					if ("weight".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetWeight(value);
					}
					
					
					
					
					
					if ("gross_weight".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGross_weight(value);
					}
					
					
					
					
					
					if ("flat_spec_props".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, string> value;
						
						value = new Dictionary<string, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								string _val0;
								_key0 = iprot.ReadString();
								
								_val0 = iprot.ReadString();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetFlat_spec_props(value);
					}
					
					
					
					
					
					if ("item_properties".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.ItemProperty> value;
						
						value = new List<com.vip.vop.cup.api.product.ItemProperty>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.ItemProperty elem1;
								
								elem1 = new com.vip.vop.cup.api.product.ItemProperty();
								com.vip.vop.cup.api.product.ItemPropertyHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItem_properties(value);
					}
					
					
					
					
					
					if ("size_table".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.SizeTable value;
						
						value = new com.vip.vop.cup.api.product.SizeTable();
						com.vip.vop.cup.api.product.SizeTableHelper.getInstance().Read(value, iprot);
						
						structs.SetSize_table(value);
					}
					
					
					
					
					
					if ("app_measurement_diagram".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApp_measurement_diagram(value);
					}
					
					
					
					
					
					if ("pc_measurement_diagram".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPc_measurement_diagram(value);
					}
					
					
					
					
					
					if ("name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetName(value);
					}
					
					
					
					
					
					if ("sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSn(value);
					}
					
					
					
					
					
					if ("brand_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBrand_id(value);
					}
					
					
					
					
					
					if ("area_output".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetArea_output(value);
					}
					
					
					
					
					
					if ("is_fragile".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_fragile(value);
					}
					
					
					
					
					
					if ("is_large".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_large(value);
					}
					
					
					
					
					
					if ("is_precious".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_precious(value);
					}
					
					
					
					
					
					if ("accessory_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccessory_info(value);
					}
					
					
					
					
					
					if ("sale_service".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSale_service(value);
					}
					
					
					
					
					
					if ("tax_rate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTax_rate(value);
					}
					
					
					
					
					
					if ("washing_instruct".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWashing_instruct(value);
					}
					
					
					
					
					
					if ("top_category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTop_category_id(value);
					}
					
					
					
					
					
					if ("sub_category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSub_category_id(value);
					}
					
					
					
					
					
					if ("is_embargo".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_embargo(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("make_up_flag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMake_up_flag(value);
					}
					
					
					
					
					
					if ("attr_spec_props".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.Attribute> value;
						
						value = new List<com.vip.vop.cup.api.product.Attribute>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.Attribute elem4;
								
								elem4 = new com.vip.vop.cup.api.product.Attribute();
								com.vip.vop.cup.api.product.AttributeHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAttr_spec_props(value);
					}
					
					
					
					
					
					if ("item_images".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.ItemImage> value;
						
						value = new List<com.vip.vop.cup.api.product.ItemImage>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.ItemImage elem6;
								
								elem6 = new com.vip.vop.cup.api.product.ItemImage();
								com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
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
								
								com.vip.vop.cup.api.product.ItemImage elem8;
								
								elem8 = new com.vip.vop.cup.api.product.ItemImage();
								com.vip.vop.cup.api.product.ItemImageHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSquare_images(value);
					}
					
					
					
					
					
					if ("market_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMarket_price(value);
					}
					
					
					
					
					
					if ("season".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeason(value);
					}
					
					
					
					
					
					if ("gender".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGender(value);
					}
					
					
					
					
					
					if ("tax_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTax_code(value);
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
		
		
		public void Write(SpuDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTitle() != null) {
				
				oprot.WriteFieldBegin("title");
				oprot.WriteString(structs.GetTitle());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShort_video() != null) {
				
				oprot.WriteFieldBegin("short_video");
				oprot.WriteString(structs.GetShort_video());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLong_video() != null) {
				
				oprot.WriteFieldBegin("long_video");
				oprot.WriteString(structs.GetLong_video());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSub_title() != null) {
				
				oprot.WriteFieldBegin("sub_title");
				oprot.WriteString(structs.GetSub_title());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory_id() != null) {
				
				oprot.WriteFieldBegin("category_id");
				oprot.WriteI32((int)structs.GetCategory_id()); 
				
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
			
			
			if(structs.GetLength() != null) {
				
				oprot.WriteFieldBegin("length");
				oprot.WriteI32((int)structs.GetLength()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWidth() != null) {
				
				oprot.WriteFieldBegin("width");
				oprot.WriteI32((int)structs.GetWidth()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHeight() != null) {
				
				oprot.WriteFieldBegin("height");
				oprot.WriteI32((int)structs.GetHeight()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWeight() != null) {
				
				oprot.WriteFieldBegin("weight");
				oprot.WriteI32((int)structs.GetWeight()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGross_weight() != null) {
				
				oprot.WriteFieldBegin("gross_weight");
				oprot.WriteI32((int)structs.GetGross_weight()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFlat_spec_props() != null) {
				
				oprot.WriteFieldBegin("flat_spec_props");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, string > _ir0 in structs.GetFlat_spec_props()){
					
					string _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItem_properties() != null) {
				
				oprot.WriteFieldBegin("item_properties");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.ItemProperty _item0 in structs.GetItem_properties()){
					
					
					com.vip.vop.cup.api.product.ItemPropertyHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_table() != null) {
				
				oprot.WriteFieldBegin("size_table");
				
				com.vip.vop.cup.api.product.SizeTableHelper.getInstance().Write(structs.GetSize_table(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApp_measurement_diagram() != null) {
				
				oprot.WriteFieldBegin("app_measurement_diagram");
				oprot.WriteString(structs.GetApp_measurement_diagram());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPc_measurement_diagram() != null) {
				
				oprot.WriteFieldBegin("pc_measurement_diagram");
				oprot.WriteString(structs.GetPc_measurement_diagram());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetName() != null) {
				
				oprot.WriteFieldBegin("name");
				oprot.WriteString(structs.GetName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSn() != null) {
				
				oprot.WriteFieldBegin("sn");
				oprot.WriteString(structs.GetSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_id() != null) {
				
				oprot.WriteFieldBegin("brand_id");
				oprot.WriteI32((int)structs.GetBrand_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetArea_output() != null) {
				
				oprot.WriteFieldBegin("area_output");
				oprot.WriteString(structs.GetArea_output());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_fragile() != null) {
				
				oprot.WriteFieldBegin("is_fragile");
				oprot.WriteBool((bool)structs.GetIs_fragile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_large() != null) {
				
				oprot.WriteFieldBegin("is_large");
				oprot.WriteBool((bool)structs.GetIs_large());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_precious() != null) {
				
				oprot.WriteFieldBegin("is_precious");
				oprot.WriteBool((bool)structs.GetIs_precious());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAccessory_info() != null) {
				
				oprot.WriteFieldBegin("accessory_info");
				oprot.WriteString(structs.GetAccessory_info());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSale_service() != null) {
				
				oprot.WriteFieldBegin("sale_service");
				oprot.WriteString(structs.GetSale_service());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTax_rate() != null) {
				
				oprot.WriteFieldBegin("tax_rate");
				oprot.WriteDouble((double)structs.GetTax_rate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWashing_instruct() != null) {
				
				oprot.WriteFieldBegin("washing_instruct");
				oprot.WriteString(structs.GetWashing_instruct());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTop_category_id() != null) {
				
				oprot.WriteFieldBegin("top_category_id");
				oprot.WriteI32((int)structs.GetTop_category_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSub_category_id() != null) {
				
				oprot.WriteFieldBegin("sub_category_id");
				oprot.WriteI32((int)structs.GetSub_category_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_embargo() != null) {
				
				oprot.WriteFieldBegin("is_embargo");
				oprot.WriteBool((bool)structs.GetIs_embargo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteString(structs.GetCreate_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMake_up_flag() != null) {
				
				oprot.WriteFieldBegin("make_up_flag");
				oprot.WriteI32((int)structs.GetMake_up_flag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAttr_spec_props() != null) {
				
				oprot.WriteFieldBegin("attr_spec_props");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.Attribute _item0 in structs.GetAttr_spec_props()){
					
					
					com.vip.vop.cup.api.product.AttributeHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
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
			
			
			if(structs.GetMarket_price() != null) {
				
				oprot.WriteFieldBegin("market_price");
				oprot.WriteDouble((double)structs.GetMarket_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeason() != null) {
				
				oprot.WriteFieldBegin("season");
				oprot.WriteString(structs.GetSeason());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGender() != null) {
				
				oprot.WriteFieldBegin("gender");
				oprot.WriteString(structs.GetGender());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTax_code() != null) {
				
				oprot.WriteFieldBegin("tax_code");
				oprot.WriteString(structs.GetTax_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpuDetail bean){
			
			
		}
		
	}
	
}