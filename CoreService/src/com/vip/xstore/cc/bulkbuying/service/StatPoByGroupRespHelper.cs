using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class StatPoByGroupRespHelper : TBeanSerializer<StatPoByGroupResp>
	{
		
		public static StatPoByGroupRespHelper OBJ = new StatPoByGroupRespHelper();
		
		public static StatPoByGroupRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StatPoByGroupResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.cc.bulkbuying.model.PaginationModel value;
						
						value = new com.vip.xstore.cc.bulkbuying.model.PaginationModel();
						com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
					}
					
					
					
					
					
					if ("list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.bulkbuying.service.PoGroup> value;
						
						value = new List<com.vip.xstore.cc.bulkbuying.service.PoGroup>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.bulkbuying.service.PoGroup elem1;
								
								elem1 = new com.vip.xstore.cc.bulkbuying.service.PoGroup();
								com.vip.xstore.cc.bulkbuying.service.PoGroupHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetList(value);
					}
					
					
					
					
					
					if ("barcodeWithoutTagPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem3;
								elem3 = iprot.ReadString();
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBarcodeWithoutTagPrice(value);
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
		
		
		public void Write(StatPoByGroupResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetList() != null) {
				
				oprot.WriteFieldBegin("list");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.bulkbuying.service.PoGroup _item0 in structs.GetList()){
					
					
					com.vip.xstore.cc.bulkbuying.service.PoGroupHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("list can not be null!");
			}
			
			
			if(structs.GetBarcodeWithoutTagPrice() != null) {
				
				oprot.WriteFieldBegin("barcodeWithoutTagPrice");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetBarcodeWithoutTagPrice()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StatPoByGroupResp bean){
			
			
		}
		
	}
	
}