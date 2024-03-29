using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.product{
	
	
	
	public class OnShelfResponseHelper : TBeanSerializer<OnShelfResponse>
	{
		
		public static OnShelfResponseHelper OBJ = new OnShelfResponseHelper();
		
		public static OnShelfResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OnShelfResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("modify_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetModify_time(value);
					}
					
					
					
					
					
					if ("op_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, bool?> value;
						
						value = new Dictionary<string, bool?>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								bool _val0;
								_key0 = iprot.ReadString();
								
								_val0 = iprot.ReadBool();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetOp_results(value);
					}
					
					
					
					
					
					if ("shelf_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, vipapis.marketplace.product.ShelfResult> value;
						
						value = new Dictionary<string, vipapis.marketplace.product.ShelfResult>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key1;
								vipapis.marketplace.product.ShelfResult _val1;
								_key1 = iprot.ReadString();
								
								
								_val1 = new vipapis.marketplace.product.ShelfResult();
								vipapis.marketplace.product.ShelfResultHelper.getInstance().Read(_val1, iprot);
								
								value.Add(_key1, _val1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetShelf_results(value);
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
		
		
		public void Write(OnShelfResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetModify_time() != null) {
				
				oprot.WriteFieldBegin("modify_time");
				oprot.WriteString(structs.GetModify_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOp_results() != null) {
				
				oprot.WriteFieldBegin("op_results");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, bool? > _ir0 in structs.GetOp_results()){
					
					string _key0 = _ir0.Key;
					bool? _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteBool((bool)_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShelf_results() != null) {
				
				oprot.WriteFieldBegin("shelf_results");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, vipapis.marketplace.product.ShelfResult > _ir0 in structs.GetShelf_results()){
					
					string _key0 = _ir0.Key;
					vipapis.marketplace.product.ShelfResult _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					vipapis.marketplace.product.ShelfResultHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OnShelfResponse bean){
			
			
		}
		
	}
	
}