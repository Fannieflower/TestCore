using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vsizetable{
	
	
	
	public class SizeDetailRequestHelper : TBeanSerializer<SizeDetailRequest>
	{
		
		public static SizeDetailRequestHelper OBJ = new SizeDetailRequestHelper();
		
		public static SizeDetailRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SizeDetailRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sizedetail_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSizedetail_id(value);
					}
					
					
					
					
					
					if ("sizedetail_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSizedetail_name(value);
					}
					
					
					
					
					
					if ("sizetable_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetSizetable_id(value);
					}
					
					
					
					
					
					if ("sizedetail_propertyvalues".Equals(schemeField.Trim())){
						
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
						
						structs.SetSizedetail_propertyvalues(value);
					}
					
					
					
					
					
					if ("size_detail_order".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSize_detail_order(value);
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
		
		
		public void Write(SizeDetailRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSizedetail_id() != null) {
				
				oprot.WriteFieldBegin("sizedetail_id");
				oprot.WriteI64((long)structs.GetSizedetail_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSizedetail_name() != null) {
				
				oprot.WriteFieldBegin("sizedetail_name");
				oprot.WriteString(structs.GetSizedetail_name());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sizedetail_name can not be null!");
			}
			
			
			if(structs.GetSizetable_id() != null) {
				
				oprot.WriteFieldBegin("sizetable_id");
				oprot.WriteI64((long)structs.GetSizetable_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sizetable_id can not be null!");
			}
			
			
			if(structs.GetSizedetail_propertyvalues() != null) {
				
				oprot.WriteFieldBegin("sizedetail_propertyvalues");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, string > _ir0 in structs.GetSizedetail_propertyvalues()){
					
					string _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_detail_order() != null) {
				
				oprot.WriteFieldBegin("size_detail_order");
				oprot.WriteI32((int)structs.GetSize_detail_order()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SizeDetailRequest bean){
			
			
		}
		
	}
	
}