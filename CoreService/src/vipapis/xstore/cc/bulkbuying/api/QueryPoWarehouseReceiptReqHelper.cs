using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class QueryPoWarehouseReceiptReqHelper : TBeanSerializer<QueryPoWarehouseReceiptReq>
	{
		
		public static QueryPoWarehouseReceiptReqHelper OBJ = new QueryPoWarehouseReceiptReqHelper();
		
		public static QueryPoWarehouseReceiptReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPoWarehouseReceiptReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("page_size".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage_size(value);
					}
					
					
					
					
					
					if ("start_create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStart_create_time(value);
					}
					
					
					
					
					
					if ("end_create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEnd_create_time(value);
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
		
		
		public void Write(QueryPoWarehouseReceiptReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage_size() != null) {
				
				oprot.WriteFieldBegin("page_size");
				oprot.WriteI32((int)structs.GetPage_size()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStart_create_time() != null) {
				
				oprot.WriteFieldBegin("start_create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_create_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnd_create_time() != null) {
				
				oprot.WriteFieldBegin("end_create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_create_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPoWarehouseReceiptReq bean){
			
			
		}
		
	}
	
}