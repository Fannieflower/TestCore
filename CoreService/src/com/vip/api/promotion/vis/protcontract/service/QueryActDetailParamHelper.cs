using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class QueryActDetailParamHelper : TBeanSerializer<QueryActDetailParam>
	{
		
		public static QueryActDetailParamHelper OBJ = new QueryActDetailParamHelper();
		
		public static QueryActDetailParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryActDetailParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
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
		
		
		public void Write(QueryActDetailParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activityType can not be null!");
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorCode can not be null!");
			}
			
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actNo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryActDetailParam bean){
			
			
		}
		
	}
	
}