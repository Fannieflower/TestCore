using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class GoodsInfoRequestHelper : TBeanSerializer<GoodsInfoRequest>
	{
		
		public static GoodsInfoRequestHelper OBJ = new GoodsInfoRequestHelper();
		
		public static GoodsInfoRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GoodsInfoRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("channelType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetChannelType(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("requestId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequestId(value);
					}
					
					
					
					
					
					if ("queryReputation".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryReputation(value);
					}
					
					
					
					
					
					if ("queryStoreServiceCapability".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetQueryStoreServiceCapability(value);
					}
					
					
					
					
					
					if ("sourceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSourceType(value);
					}
					
					
					
					
					
					if ("jxCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetJxCode(value);
					}
					
					
					
					
					
					if ("fieldName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFieldName(value);
					}
					
					
					
					
					
					if ("order".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrder(value);
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
		
		
		public void Write(GoodsInfoRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetChannelType() != null) {
				
				oprot.WriteFieldBegin("channelType");
				oprot.WriteI32((int)structs.GetChannelType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestId() != null) {
				
				oprot.WriteFieldBegin("requestId");
				oprot.WriteString(structs.GetRequestId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestId can not be null!");
			}
			
			
			if(structs.GetQueryReputation() != null) {
				
				oprot.WriteFieldBegin("queryReputation");
				oprot.WriteBool((bool)structs.GetQueryReputation());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQueryStoreServiceCapability() != null) {
				
				oprot.WriteFieldBegin("queryStoreServiceCapability");
				oprot.WriteBool((bool)structs.GetQueryStoreServiceCapability());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceType() != null) {
				
				oprot.WriteFieldBegin("sourceType");
				oprot.WriteI32((int)structs.GetSourceType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetJxCode() != null) {
				
				oprot.WriteFieldBegin("jxCode");
				oprot.WriteString(structs.GetJxCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFieldName() != null) {
				
				oprot.WriteFieldBegin("fieldName");
				oprot.WriteString(structs.GetFieldName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder() != null) {
				
				oprot.WriteFieldBegin("order");
				oprot.WriteI32((int)structs.GetOrder()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GoodsInfoRequest bean){
			
			
		}
		
	}
	
}