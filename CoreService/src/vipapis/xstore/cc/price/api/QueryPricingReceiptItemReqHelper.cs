using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class QueryPricingReceiptItemReqHelper : TBeanSerializer<QueryPricingReceiptItemReq>
	{
		
		public static QueryPricingReceiptItemReqHelper OBJ = new QueryPricingReceiptItemReqHelper();
		
		public static QueryPricingReceiptItemReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPricingReceiptItemReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("page_size".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage_size(value);
					}
					
					
					
					
					
					if ("pricing_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPricing_no(value);
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
		
		
		public void Write(QueryPricingReceiptItemReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPage_size() != null) {
				
				oprot.WriteFieldBegin("page_size");
				oprot.WriteI32((int)structs.GetPage_size()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page_size can not be null!");
			}
			
			
			if(structs.GetPricing_no() != null) {
				
				oprot.WriteFieldBegin("pricing_no");
				oprot.WriteString(structs.GetPricing_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pricing_no can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPricingReceiptItemReq bean){
			
			
		}
		
	}
	
}