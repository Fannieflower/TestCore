using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class GetAscsRequestHelper : TBeanSerializer<GetAscsRequest>
	{
		
		public static GetAscsRequestHelper OBJ = new GetAscsRequestHelper();
		
		public static GetAscsRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetAscsRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("query_start_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetQuery_start_time(value);
					}
					
					
					
					
					
					if ("query_end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetQuery_end_time(value);
					}
					
					
					
					
					
					if ("asc_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAsc_type(value);
					}
					
					
					
					
					
					if ("asc_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetAsc_status(value);
					}
					
					
					
					
					
					if ("refund_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRefund_status(value);
					}
					
					
					
					
					
					if ("limit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLimit(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
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
		
		
		public void Write(GetAscsRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuery_start_time() != null) {
				
				oprot.WriteFieldBegin("query_start_time");
				oprot.WriteString(structs.GetQuery_start_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuery_end_time() != null) {
				
				oprot.WriteFieldBegin("query_end_time");
				oprot.WriteString(structs.GetQuery_end_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_type() != null) {
				
				oprot.WriteFieldBegin("asc_type");
				oprot.WriteByte((byte)structs.GetAsc_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAsc_status() != null) {
				
				oprot.WriteFieldBegin("asc_status");
				oprot.WriteByte((byte)structs.GetAsc_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_status() != null) {
				
				oprot.WriteFieldBegin("refund_status");
				oprot.WriteI32((int)structs.GetRefund_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLimit() != null) {
				
				oprot.WriteFieldBegin("limit");
				oprot.WriteI32((int)structs.GetLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetAscsRequest bean){
			
			
		}
		
	}
	
}