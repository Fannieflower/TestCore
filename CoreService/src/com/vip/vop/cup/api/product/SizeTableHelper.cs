using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class SizeTableHelper : TBeanSerializer<SizeTable>
	{
		
		public static SizeTableHelper OBJ = new SizeTableHelper();
		
		public static SizeTableHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SizeTable structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("html".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHtml(value);
					}
					
					
					
					
					
					if ("tips".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTips(value);
					}
					
					
					
					
					
					if ("del_flag".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetDel_flag(value);
					}
					
					
					
					
					
					if ("details".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<long?, com.vip.vop.cup.api.product.SizeDetail> value;
						
						value = new Dictionary<long?, com.vip.vop.cup.api.product.SizeDetail>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								long _key0;
								com.vip.vop.cup.api.product.SizeDetail _val0;
								_key0 = iprot.ReadI64(); 
								
								
								_val0 = new com.vip.vop.cup.api.product.SizeDetail();
								com.vip.vop.cup.api.product.SizeDetailHelper.getInstance().Read(_val0, iprot);
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetDetails(value);
					}
					
					
					
					
					
					if ("recommend_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRecommend_info(value);
					}
					
					
					
					
					
					if ("json_data".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetJson_data(value);
					}
					
					
					
					
					
					if ("size_type_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSize_type_id(value);
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
		
		
		public void Write(SizeTable structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteI16((short)structs.GetType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHtml() != null) {
				
				oprot.WriteFieldBegin("html");
				oprot.WriteString(structs.GetHtml());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTips() != null) {
				
				oprot.WriteFieldBegin("tips");
				oprot.WriteString(structs.GetTips());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDel_flag() != null) {
				
				oprot.WriteFieldBegin("del_flag");
				oprot.WriteI16((short)structs.GetDel_flag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetails() != null) {
				
				oprot.WriteFieldBegin("details");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< long?, com.vip.vop.cup.api.product.SizeDetail > _ir0 in structs.GetDetails()){
					
					long? _key0 = _ir0.Key;
					com.vip.vop.cup.api.product.SizeDetail _value0 = _ir0.Value;
					oprot.WriteI64((long)_key0); 
					
					
					com.vip.vop.cup.api.product.SizeDetailHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecommend_info() != null) {
				
				oprot.WriteFieldBegin("recommend_info");
				oprot.WriteString(structs.GetRecommend_info());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetJson_data() != null) {
				
				oprot.WriteFieldBegin("json_data");
				oprot.WriteString(structs.GetJson_data());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize_type_id() != null) {
				
				oprot.WriteFieldBegin("size_type_id");
				oprot.WriteI32((int)structs.GetSize_type_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SizeTable bean){
			
			
		}
		
	}
	
}