using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class ItemImageHelper : TBeanSerializer<ItemImage>
	{
		
		public static ItemImageHelper OBJ = new ItemImageHelper();
		
		public static ItemImageHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ItemImage structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("item_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetItem_id(value);
					}
					
					
					
					
					
					if ("description".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDescription(value);
					}
					
					
					
					
					
					if ("image_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetImage_url(value);
					}
					
					
					
					
					
					if ("image_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetImage_type(value);
					}
					
					
					
					
					
					if ("image_size".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetImage_size(value);
					}
					
					
					
					
					
					if ("image_index".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetImage_index(value);
					}
					
					
					
					
					
					if ("operation_mode".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.OperationMode? value;
						
						value = com.vip.vop.cup.api.product.OperationModeUtil.FindByName(iprot.ReadString());
						
						structs.SetOperation_mode(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetStatus(value);
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
		
		
		public void Write(ItemImage structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItem_id() != null) {
				
				oprot.WriteFieldBegin("item_id");
				oprot.WriteI64((long)structs.GetItem_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDescription() != null) {
				
				oprot.WriteFieldBegin("description");
				oprot.WriteString(structs.GetDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_url() != null) {
				
				oprot.WriteFieldBegin("image_url");
				oprot.WriteString(structs.GetImage_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_type() != null) {
				
				oprot.WriteFieldBegin("image_type");
				oprot.WriteString(structs.GetImage_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_size() != null) {
				
				oprot.WriteFieldBegin("image_size");
				oprot.WriteString(structs.GetImage_size());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImage_index() != null) {
				
				oprot.WriteFieldBegin("image_index");
				oprot.WriteI32((int)structs.GetImage_index()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperation_mode() != null) {
				
				oprot.WriteFieldBegin("operation_mode");
				oprot.WriteString(structs.GetOperation_mode().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI16((short)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ItemImage bean){
			
			
		}
		
	}
	
}