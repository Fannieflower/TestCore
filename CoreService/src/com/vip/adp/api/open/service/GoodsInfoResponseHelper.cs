using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class GoodsInfoResponseHelper : TBeanSerializer<GoodsInfoResponse>
	{
		
		public static GoodsInfoResponseHelper OBJ = new GoodsInfoResponseHelper();
		
		public static GoodsInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GoodsInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsInfoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.GoodsInfo> value;
						
						value = new List<com.vip.adp.api.open.service.GoodsInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.GoodsInfo elem0;
								
								elem0 = new com.vip.adp.api.open.service.GoodsInfo();
								com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsInfoList(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("sortFields".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.SortField> value;
						
						value = new List<com.vip.adp.api.open.service.SortField>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.SortField elem2;
								
								elem2 = new com.vip.adp.api.open.service.SortField();
								com.vip.adp.api.open.service.SortFieldHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSortFields(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
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
		
		
		public void Write(GoodsInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsInfoList() != null) {
				
				oprot.WriteFieldBegin("goodsInfoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.GoodsInfo _item0 in structs.GetGoodsInfoList()){
					
					
					com.vip.adp.api.open.service.GoodsInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSortFields() != null) {
				
				oprot.WriteFieldBegin("sortFields");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.SortField _item0 in structs.GetSortFields()){
					
					
					com.vip.adp.api.open.service.SortFieldHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GoodsInfoResponse bean){
			
			
		}
		
	}
	
}